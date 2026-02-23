using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPrereqState : gamePrereqState
	{
		private CHandle<StatPrereqListener> _listener;
		private CFloat _modifiersValueToCheck;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<StatPrereqListener> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(1)] 
		[RED("modifiersValueToCheck")] 
		public CFloat ModifiersValueToCheck
		{
			get => GetProperty(ref _modifiersValueToCheck);
			set => SetProperty(ref _modifiersValueToCheck, value);
		}

		public StatPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
