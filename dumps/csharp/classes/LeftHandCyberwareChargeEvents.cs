using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareChargeEvents : LeftHandCyberwareEventsTransition
	{
		private CHandle<gameweaponAnimFeature_AimPlayer> _chargeModeAim;
		private wCHandle<gameweaponObject> _leftHandObject;
		private CFloat _aimInTimeRemaining;

		[Ordinal(2)] 
		[RED("chargeModeAim")] 
		public CHandle<gameweaponAnimFeature_AimPlayer> ChargeModeAim
		{
			get => GetProperty(ref _chargeModeAim);
			set => SetProperty(ref _chargeModeAim, value);
		}

		[Ordinal(3)] 
		[RED("leftHandObject")] 
		public wCHandle<gameweaponObject> LeftHandObject
		{
			get => GetProperty(ref _leftHandObject);
			set => SetProperty(ref _leftHandObject, value);
		}

		[Ordinal(4)] 
		[RED("aimInTimeRemaining")] 
		public CFloat AimInTimeRemaining
		{
			get => GetProperty(ref _aimInTimeRemaining);
			set => SetProperty(ref _aimInTimeRemaining, value);
		}

		public LeftHandCyberwareChargeEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
