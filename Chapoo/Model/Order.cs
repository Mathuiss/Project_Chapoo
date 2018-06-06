namespace Chapoo.Model
{
    public struct Order
    {
        public int Id { get; set; }
        public int User { get; set; }
        public int Table { get; set; }
        public BestelStatus Status { get; set; }

        public Order(int _id, int _user, int _table, BestelStatus _status)
        {
            Id = _id;
            User = _user;
            Table = _table;
            Status = _status;
        }
    }
}
