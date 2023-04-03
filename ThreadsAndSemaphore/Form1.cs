using System.Threading;

namespace ThreadsAndSemaphore
{
    public partial class Form1 : Form
    {

        private Semaphore semaphore;
        private int semaphoreCount;
        private int nextThreadNumber;
        private List<Thread> createdThreads;
        private List<Thread> waitingThreads;
        private List<Thread> workingThreads;

        public Form1()
        {
            InitializeComponent();
            semaphoreCount = (int)PleasesInSemaphore.Value;
            semaphore = new Semaphore(semaphoreCount, semaphoreCount);
            createdThreads = new List<Thread>();
            waitingThreads = new List<Thread>();
            workingThreads = new List<Thread>();
            nextThreadNumber = 1;
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ThreadMethod);
            thread.Name = "Thread #" + nextThreadNumber;
            createdThreads.Add(thread);
            CreateThreadsList.Items.Add(thread.Name);
            nextThreadNumber++;
        }

       void ThreadMethod()
        {

            Thread thisThread = Thread.CurrentThread;
            Thread.Sleep(5000);
            workingThreads.Remove(thisThread);
            WorkThreadsList.Items.RemoveAt(0);
            semaphore.Release();
        }

        private void CreateThreadsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = CreateThreadsList.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                Thread thread = createdThreads[index];
                createdThreads.Remove(thread);
                CreateThreadsList.Items.RemoveAt(index);

                if (semaphore.WaitOne(0))
                {
                    workingThreads.Add(thread);
                    WorkThreadsList.Items.Add(thread.Name);
                    thread.Start();
                }
                else
                {
                    waitingThreads.Add(thread);
                    WaitThreadsList.Items.Add(thread.Name);
                    while (true)
                    {



                        if (semaphore.WaitOne(0) && waitingThreads.Count != 0)
                        {
                            
                            workingThreads.Add(thread);
                            WorkThreadsList.Items.Add(thread.Name);
                            thread.Start();
                            waitingThreads.RemoveAt(0);
                            WaitThreadsList.Items.Remove(thread.Name);
                            break;
                        }

                    }
                }
            }
        }

        



        private void PleasesInSemaphore_ValueChanged(object sender, EventArgs e)
        {
            semaphore = new Semaphore((int)PleasesInSemaphore.Value, (int)PleasesInSemaphore.Value);
        }








        private void WaitThreadsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = WaitThreadsList.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                Thread thread = waitingThreads[index];
                waitingThreads.Remove(thread);
                WaitThreadsList.Items.RemoveAt(index);

                workingThreads.Add(thread);
                WorkThreadsList.Items.Add(thread.Name);

                semaphore.Release();
            }
        }

        private void WorkThreadsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = WorkThreadsList.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                Thread thread = workingThreads[index];
                workingThreads.Remove(thread);
                WorkThreadsList.Items.RemoveAt(index);

                if (waitingThreads.Count > 0 && semaphoreCount > semaphore.Release())
                {
                    Thread nextThread = waitingThreads[0];
                    waitingThreads.RemoveAt(0);
                    WaitThreadsList.Items.RemoveAt(0);

                    workingThreads.Add(nextThread);
                    WorkThreadsList.Items.Add(nextThread.Name);

                    semaphore.Release();
                }
            }
        }
    }
}