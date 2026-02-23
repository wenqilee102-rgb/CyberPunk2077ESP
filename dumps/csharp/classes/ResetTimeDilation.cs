using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResetTimeDilation : redEvent
	{
		private CName _easeOut;
		private CBool _global;

		[Ordinal(0)] 
		[RED("easeOut")] 
		public CName EaseOut
		{
			get => GetProperty(ref _easeOut);
			set => SetProperty(ref _easeOut, value);
		}

		[Ordinal(1)] 
		[RED("global")] 
		public CBool Global
		{
			get => GetProperty(ref _global);
			set => SetProperty(ref _global, value);
		}

		public ResetTimeDilation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
