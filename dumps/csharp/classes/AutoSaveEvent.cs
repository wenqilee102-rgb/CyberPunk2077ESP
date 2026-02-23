using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AutoSaveEvent : redEvent
	{
		private CInt32 _maxAttempts;
		private CBool _isForced;

		[Ordinal(0)] 
		[RED("maxAttempts")] 
		public CInt32 MaxAttempts
		{
			get => GetProperty(ref _maxAttempts);
			set => SetProperty(ref _maxAttempts, value);
		}

		[Ordinal(1)] 
		[RED("isForced")] 
		public CBool IsForced
		{
			get => GetProperty(ref _isForced);
			set => SetProperty(ref _isForced, value);
		}

		public AutoSaveEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
