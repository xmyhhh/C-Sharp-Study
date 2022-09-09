
//nested class example
using System.Collections.Generic;


public class NoteLink
{
    // ...

    public NoteLink()
    {
        List<NoteLinkDetail_Public> _noteLinkDetails1 = new List<NoteLinkDetail_Public>();
        List<NoteLinkDetail_Private> _noteLinkDetails2 = new List<NoteLinkDetail_Private>();
    }

    public class NoteLinkDetail_Public
    {
        public string L { get; set; }
        public string R { get; set; }
    }
    class NoteLinkDetail_Private
    {
        public string L { get; set; }
        public string R { get; set; }
    }
}


public class TestClass
{

    public NoteLinkDetail_Public noteLinkDetail1;   //accessable
    public NoteLink.NoteLinkDetail_Public noteLinkDetail2;   //accessable too
    //public NoteLinkDetail_Private noteLinkDetail3;  //not accessable
}