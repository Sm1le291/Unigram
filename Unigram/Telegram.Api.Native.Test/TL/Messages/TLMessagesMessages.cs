// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages
{
	public partial class TLMessagesMessages : TLMessagesMessagesBase 
	{
		public TLMessagesMessages() { }
		public TLMessagesMessages(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesMessages; } }

		public override void Read(TLBinaryReader from)
		{
			Messages = TLFactory.Read<TLVector<TLMessageBase>>(from);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Messages);
			to.WriteObject(Chats);
			to.WriteObject(Users);
		}
	}
}