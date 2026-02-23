using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DriverCombatListener : IScriptable
	{
		private CHandle<redCallbackObject> _mountedCallback;
		private CHandle<redCallbackObject> _tppCallback;
		private CBool _isMounted;
		private CBool _isInTPP;

		[Ordinal(0)] 
		[RED("mountedCallback")] 
		public CHandle<redCallbackObject> MountedCallback
		{
			get => GetProperty(ref _mountedCallback);
			set => SetProperty(ref _mountedCallback, value);
		}

		[Ordinal(1)] 
		[RED("tppCallback")] 
		public CHandle<redCallbackObject> TppCallback
		{
			get => GetProperty(ref _tppCallback);
			set => SetProperty(ref _tppCallback, value);
		}

		[Ordinal(2)] 
		[RED("isMounted")] 
		public CBool IsMounted
		{
			get => GetProperty(ref _isMounted);
			set => SetProperty(ref _isMounted, value);
		}

		[Ordinal(3)] 
		[RED("isInTPP")] 
		public CBool IsInTPP
		{
			get => GetProperty(ref _isInTPP);
			set => SetProperty(ref _isInTPP, value);
		}

		public DriverCombatListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
