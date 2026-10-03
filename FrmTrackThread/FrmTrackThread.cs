namespace FrmTrackThread
{
    public partial class FrmTrackThread : Form
    {
        public FrmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            lblShowStatus.Text = "- Thread Starts -";
            lblShowStatus.Refresh();
            Console.WriteLine("- Thread Starts -");

            Thread threadA = new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread2);
            Thread threadC = new Thread(MyThreadClass.Thread1);
            Thread threadD = new Thread(MyThreadClass.Thread2);

            threadA.Name = "Thread A Process";
            threadB.Name = "Thread B Process";
            threadC.Name = "Thread C Process";
            threadD.Name = "Thread D Process";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("- End of Thread -");
            lblShowStatus.Text = "- End of Thread -";
        }
    }
}
