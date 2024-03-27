using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public int Capacity { get; private set; }
        public List<Mail> Inbox { get; private set; }
        public List<Mail> Archive { get; private set; }

        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }

        public bool DeleteMail(string sender)
        {
            Mail mail = Inbox.FirstOrDefault(x => x.Sender == sender);

            if (mail != null)
            {
                Inbox.Remove(mail);
                return true;
            }

            return false;
        }

        public int ArchiveInboxMessages()
        {
            int archivedMails = 0;

            for (int i = 0; i < Inbox.Count; i++)
            {
                Archive.Add(Inbox[i]);
                archivedMails++;
            }

            Inbox.Clear();
            return archivedMails;
        }

        public string GetLongestMessage()
        {
            return Inbox.MaxBy(m => m.Body.Length).ToString();
        }

        public string InboxView()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Inbox:");
            
            foreach (Mail mail in Inbox)
            {
                stringBuilder.AppendLine(mail.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
