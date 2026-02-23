using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsMountedByPreventionNPCPrereq : gameIScriptablePrereq
	{
		private CBool _isCheckInverted;

		[Ordinal(0)] 
		[RED("isCheckInverted")] 
		public CBool IsCheckInverted
		{
			get => GetProperty(ref _isCheckInverted);
			set => SetProperty(ref _isCheckInverted, value);
		}

		public IsMountedByPreventionNPCPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
