using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _3Harder_Problem_Program
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class DataManager
    {
        private SQLiteConnection connection;

        public DataManager()
        {
            connection = new SQLiteConnection();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = "CREATE DATABASE IF NOT EXISTS logs(TEXT problem_id PRIMARY KEY, TEXT date, TEXT name, TEXT priority, TEXT problem_type, TEXT room_id, TEXT description); CREATE DATABASE IF NOT EXISTS users(TEXT username, TEXT password)"; //TODO
        }

        public bool save(ProblemBuilder.Problem problem)
        {
            SQLiteCommand cmd = new SQLiteCommand();

            cmd.CommandText = "";
            return true;
        }
    }

    public class ProblemBuilder
    {
        private String problemId;
        private DateTime time;
        private String name;
        private Priority priority;
        private Type problemType;
        private String roomId;
        private String[] description;

        public ProblemBuilder(String problemId)
        {
            if (problemId == null)
            {
                throw new NoNullAllowedException("problemId is null in ProblemBuilder contructor.");
            }

            this.problemId = problemId;
        }

        public ProblemBuilder WithTime(DateTime time)
        {
            this.time = time;
            return this;
        }

        public ProblemBuilder WithName(String name)
        {
            if (name == null)
            {
                throw new NoNullAllowedException("Name cannot be null.");
            }

            this.name = name;
            return this;
        }

        public ProblemBuilder WithPriority(Priority priority)
        {
            this.priority = priority;
            return this;
        }

        public ProblemBuilder WithProblemType(Type type)
        {
            problemType = type;
            return this;
        }

        public ProblemBuilder WithRoomId(String roomId)
        {
            if (roomId == null)
            {
                throw new NoNullAllowedException("Room id cannot be null.");
            }

            this.roomId = roomId;
            return this;
        }

        public ProblemBuilder WithDescription(String[] description)
        {
            this.description = description;
            return this;
        }

        public Problem build()
        {
            return new Problem(problemId, time, name, priority, problemType, roomId, description);
        }

    public class Problem
    {
        private String problemId;
        private DateTime date;
        private String name;
        private Priority priority;
        private Type problemType;
        private String roomId;
        private String[] description;

        public Problem(String problemId, DateTime date, String name, Priority priority, Type problemType, String roomId, String[] description)
        {
            this.problemId = problemId;

            if (date == null)
            {
                date = new DateTime();
            }

            this.name = name;
            this.priority = priority;
            this.problemType = problemType;
            this.roomId = roomId;
            this.description = description;
        }

        public String GetProblemId()
        {
            return problemId;
        }

        public DateTime GetDateTime()
        {
            return date;
        }

        public String GetName()
        {
            return name;
        }

        public Priority GetPriority()
        {
            return priority;
        }
        
        public Type GetType()
        {
            return problemType;
        }

        public String GetRoomId()
        {
            return roomId;
        }

        public String[] GetDescription()
        {
            return description;
        }
    }

    public enum Priority
    {
        LOW,
        MEDIUM,
        HIGH
    }

    public enum Type
    {
        HARDWARE,
        SOFTWARE,
        TELECOMMUNICATION
    }
}
