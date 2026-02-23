using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TemporaryUnequipEvents : UpperBodyEventsTransition
	{
		private CBool _forceOpen;
		private CBool _hadStrongArmsEquipped;

		[Ordinal(6)] 
		[RED("forceOpen")] 
		public CBool ForceOpen
		{
			get => GetProperty(ref _forceOpen);
			set => SetProperty(ref _forceOpen, value);
		}

		[Ordinal(7)] 
		[RED("hadStrongArmsEquipped")] 
		public CBool HadStrongArmsEquipped
		{
			get => GetProperty(ref _hadStrongArmsEquipped);
			set => SetProperty(ref _hadStrongArmsEquipped, value);
		}

		public TemporaryUnequipEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
