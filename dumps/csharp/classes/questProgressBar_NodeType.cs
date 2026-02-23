using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questProgressBar_NodeType : questIUIManagerNodeType
	{
		private CBool _show;
		private CFloat _duration;
		private LocalizationString _text;
		private LocalizationString _bottomText;
		private CEnum<gameSimpleMessageType> _type;

		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetProperty(ref _show);
			set => SetProperty(ref _show, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(3)] 
		[RED("bottomText")] 
		public LocalizationString BottomText
		{
			get => GetProperty(ref _bottomText);
			set => SetProperty(ref _bottomText, value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameSimpleMessageType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public questProgressBar_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
