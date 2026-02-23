using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDProgressBarData : CVariable
	{
		private CString _header;
		private CString _bottomText;
		private CString _completedText;
		private CString _failedText;
		private CBool _active;
		private CFloat _progress;
		private CEnum<gameSimpleMessageType> _type;

		[Ordinal(0)] 
		[RED("header")] 
		public CString Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(1)] 
		[RED("bottomText")] 
		public CString BottomText
		{
			get => GetProperty(ref _bottomText);
			set => SetProperty(ref _bottomText, value);
		}

		[Ordinal(2)] 
		[RED("completedText")] 
		public CString CompletedText
		{
			get => GetProperty(ref _completedText);
			set => SetProperty(ref _completedText, value);
		}

		[Ordinal(3)] 
		[RED("failedText")] 
		public CString FailedText
		{
			get => GetProperty(ref _failedText);
			set => SetProperty(ref _failedText, value);
		}

		[Ordinal(4)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(5)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		[Ordinal(6)] 
		[RED("type")] 
		public CEnum<gameSimpleMessageType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public HUDProgressBarData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
