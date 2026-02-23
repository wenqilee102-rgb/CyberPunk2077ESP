using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CancelDelamainRideRequest : gameScriptableSystemRequest
	{
		private CBool _forceExit;

		[Ordinal(0)] 
		[RED("forceExit")] 
		public CBool ForceExit
		{
			get => GetProperty(ref _forceExit);
			set => SetProperty(ref _forceExit, value);
		}

		public CancelDelamainRideRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
