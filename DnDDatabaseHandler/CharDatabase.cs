

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using DnDSimulator.Model;


namespace DnDDatabase.Charakters
{
    public class CharDatabase
    {
        private readonly SQLiteConnection connection;
        private bool disposed = false;
        private CharDatabaseTransactionScope currentScope = null;
        private readonly string sqlFilePath;
        private string projectFolder;
        private string path;


        public CharDatabase()
        {
            projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            path = Path.Combine(projectFolder, @"DataBases\Charakters.sqlite");

            if (path == null)
                throw new ArgumentNullException("path");

            sqlFilePath = path;

            try
            {
                if (!File.Exists(sqlFilePath))
                    using (File.Create(sqlFilePath)) { }

                connection = GetConnection(sqlFilePath);
                SqlRunPragmas(connection);

                using (var scope = BeginTransaction())
                {

                    try
                    {

                        SqlInitSchema();

                        //if (!SqlTrySelect(out model))
                        //{
                        //    model = CreateDefaultModel();
                        //    SqlSave(model);
                        //}

                        scope.Commit();
                    }
                    catch
                    {
                        scope.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error opening mzlite sql file.", ex);
            }
        }
        #region sql statements

        private static SQLiteConnection GetConnection(string path)
        {
            SQLiteConnection conn =
                new SQLiteConnection(string.Format("DataSource={0}", path));
            if (conn.State != ConnectionState.Open)
                conn.Open();
            return conn;
        }

        private static void SqlRunPragmas(SQLiteConnection conn)
        {
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "PRAGMA synchronous=OFF";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "PRAGMA journal_mode=MEMORY";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "PRAGMA temp_store=MEMORY";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "PRAGMA ignore_check_constraints=OFF";
                cmd.ExecuteNonQuery();
            }
        }

        private void RaiseDisposed()
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().Name);
        }

        public ITransactionScope BeginTransaction()
        {

            RaiseDisposed();

            if (IsOpenScope)
                throw new Exception("Illegal attempt transaction scope reentrancy.");

            try
            {
                currentScope = new CharDatabaseTransactionScope(this, connection);
                return currentScope;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        internal void ReleaseTransactionScope()
        {
            currentScope = null;
        }

        private bool IsOpenScope { get { return currentScope != null; } }

        private void RaiseNotInScope()
        {
            if (!IsOpenScope)
                throw new Exception("No transaction scope was initialized.");
        }

        private void SqlInitSchema()
        {
            using (SQLiteCommand cmd = currentScope.CreateCommand("CREATE TABLE IF NOT EXISTS Charakters (ID INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT, Name TEXT NOT NULL, HitPoints INTEGER NOT NULL, ArmourClass INTEGER NOT NULL, Initiative INTEGER NOT NULL, AttackBonus INTEGER NOT NULL, Damage INTEGER NOT NULL, Movement INTEGER NOT NULL)"))
                cmd.ExecuteNonQuery();
        }

        //private void SqlInsert(string runID, MassSpectrum spectrum, Peak1DArray peaks)
        //{
        //    SQLiteCommand cmd;

        //    if (!currentScope.TryGetCommand("INSERT_SPECTRUM_CMD", out cmd))
        //    {
        //        cmd = currentScope.PrepareCommand("INSERT_SPECTRUM_CMD", "INSERT INTO Spectrum VALUES(@runID, @spectrumID, @description, @peakArray, @peakData);");
        //    }

        //    cmd.Parameters.Clear();
        //    cmd.Parameters.AddWithValue("@runID", runID);
        //    cmd.Parameters.AddWithValue("@spectrumID", spectrum.ID);
        //    cmd.Parameters.AddWithValue("@description", MzLiteJson.ToJson(spectrum));
        //    cmd.Parameters.AddWithValue("@peakArray", MzLiteJson.ToJson(peaks));
        //    cmd.Parameters.AddWithValue("@peakData", encoder.Encode(peaks));

        //    cmd.ExecuteNonQuery();

        //}

        //private void SqlSave(MzLiteModel model)
        //{
        //    using (SQLiteCommand cmd = currentScope.CreateCommand("DELETE FROM Model"))
        //    {
        //        cmd.ExecuteNonQuery();
        //    }

        //    using (SQLiteCommand cmd = currentScope.CreateCommand("INSERT INTO Model VALUES(@lock, @content)"))
        //    {
        //        cmd.Parameters.AddWithValue("@lock", 0);
        //        cmd.Parameters.AddWithValue("@content", MzLiteJson.ToJson(model));
        //        cmd.ExecuteNonQuery();
        //    }

        //}

        //private bool SqlTrySelect(out MzLiteModel model)
        //{
        //    using (SQLiteCommand cmd = currentScope.CreateCommand("SELECT Content FROM Model"))
        //    {
        //        string content = cmd.ExecuteScalar() as string;

        //        if (content != null)
        //        {
        //            model = MzLiteJson.FromJson<MzLiteModel>(content);
        //            return true;
        //        }
        //        else
        //        {
        //            model = null;
        //            return false;
        //        }
        //    }

        //}

        //private IEnumerable<MassSpectrum> SqlSelectMassSpectra(string runID)
        //{

        //    using (SQLiteCommand cmd = currentScope.CreateCommand("SELECT Description FROM Spectrum WHERE RunID = @runID"))
        //    {

        //        cmd.Parameters.AddWithValue("@runID", runID);

        //        using (SQLiteDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                yield return MzLiteJson.FromJson<MassSpectrum>(reader.GetString(0));
        //            }
        //        }
        //    }

        //}

        //private IEnumerable<Chromatogram> SqlSelectChromatograms(string runID)
        //{

        //    using (SQLiteCommand cmd = currentScope.CreateCommand("SELECT Description FROM Chromatogram WHERE RunID = @runID"))
        //    {

        //        cmd.Parameters.AddWithValue("@runID", runID);

        //        using (SQLiteDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                yield return MzLiteJson.FromJson<Chromatogram>(reader.GetString(0));
        //            }
        //        }
        //    }

        //}

        #endregion
    }
    /// <summary>
    /// Provides prepared statements within a SQLite connection.
    /// </summary>
    internal class CharDatabaseTransactionScope : ITransactionScope
    {

        private readonly SQLiteConnection connection;
        private readonly SQLiteTransaction transaction;
        private readonly CharDatabase writer;
        private readonly IDictionary<string, SQLiteCommand> commands = new Dictionary<string, SQLiteCommand>();
        private bool disposed = false;

        #region ITransactionScope Members

        public void Commit()
        {
            RaiseDisposed();

            try
            {
                transaction.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Rollback()
        {
            RaiseDisposed();

            try
            {
                transaction.Rollback();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }



        #endregion

        #region MzLiteSQLTransactionScope Members

        internal CharDatabaseTransactionScope(CharDatabase writer, SQLiteConnection connection)
        {
            this.connection = connection;
            this.transaction = connection.BeginTransaction();
            this.writer = writer;
        }

        internal SQLiteCommand PrepareCommand(string name, string commandText)
        {

            RaiseDisposed();

            SQLiteCommand cmd = CreateCommand(commandText);
            cmd.Prepare();
            commands[name] = cmd;
            return cmd;
        }

        internal SQLiteCommand CreateCommand(string commandText)
        {

            RaiseDisposed();

            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = commandText;
            cmd.Transaction = transaction;
            return cmd;
        }

        internal bool TryGetCommand(string name, out SQLiteCommand cmd)
        {
            RaiseDisposed();
            return commands.TryGetValue(name, out cmd);
        }

        #endregion

        #region IDisposable Members

        private void RaiseDisposed()
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().Name);
        }

        public void Dispose()
        {
            if (disposed)
                return;

            foreach (var cmd in commands.Values)
                cmd.Dispose();
            commands.Clear();

            if (transaction != null)
                transaction.Dispose();

            writer.ReleaseTransactionScope();

            disposed = true;
        }

        #endregion
    }
}

public interface ITransactionScope : IDisposable
{
    void Commit();
    void Rollback();
}
