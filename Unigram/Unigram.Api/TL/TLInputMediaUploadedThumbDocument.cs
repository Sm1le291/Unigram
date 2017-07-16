// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputMediaUploadedThumbDocument : TLInputMediaBase, ITLMessageMediaCaption 
	{
		[Flags]
		public enum Flag : Int32
		{
			Stickers = (1 << 0),
		}

		public bool HasStickers { get { return Flags.HasFlag(Flag.Stickers); } set { Flags = value ? (Flags | Flag.Stickers) : (Flags & ~Flag.Stickers); } }

		public Flag Flags { get; set; }
		public TLInputFileBase File { get; set; }
		public TLInputFileBase Thumb { get; set; }
		public String MimeType { get; set; }
		public TLVector<TLDocumentAttributeBase> Attributes { get; set; }
		public String Caption { get; set; }
		public TLVector<TLInputDocumentBase> Stickers { get; set; }

		public TLInputMediaUploadedThumbDocument() { }
		public TLInputMediaUploadedThumbDocument(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputMediaUploadedThumbDocument; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			File = TLFactory.Read<TLInputFileBase>(from);
			Thumb = TLFactory.Read<TLInputFileBase>(from);
			MimeType = from.ReadString();
			Attributes = TLFactory.Read<TLVector<TLDocumentAttributeBase>>(from);
			Caption = from.ReadString();
			if (HasStickers) Stickers = TLFactory.Read<TLVector<TLInputDocumentBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteObject(File);
			to.WriteObject(Thumb);
			to.WriteString(MimeType ?? string.Empty);
			to.WriteObject(Attributes);
			to.WriteString(Caption ?? string.Empty);
			if (HasStickers) to.WriteObject(Stickers);
		}

		private void UpdateFlags()
		{
			HasStickers = Stickers != null;
		}
	}
}