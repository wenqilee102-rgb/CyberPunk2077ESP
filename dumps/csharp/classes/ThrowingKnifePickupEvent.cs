using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowingKnifePickupEvent : redEvent
	{
		private TweakDBID _throwCooldownSE;

		[Ordinal(0)] 
		[RED("throwCooldownSE")] 
		public TweakDBID ThrowCooldownSE
		{
			get => GetProperty(ref _throwCooldownSE);
			set => SetProperty(ref _throwCooldownSE, value);
		}

		public ThrowingKnifePickupEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
