using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_BlackwallForce : CrosshairGameController_Smart_Rifl
	{
		private CHandle<gamesmartGunUIParameters> _lastSmartParams;
		private CHandle<gamesmartGunUIParameters> _smartGunData;
		private CArray<gamesmartGunUITargetParameters> _targetList;
		private gamesmartGunUITargetParameters _targetData;
		private CInt32 _numOfTargets;
		private wCHandle<gameObject> _owner;

		[Ordinal(72)] 
		[RED("lastSmartParams")] 
		public CHandle<gamesmartGunUIParameters> LastSmartParams
		{
			get => GetProperty(ref _lastSmartParams);
			set => SetProperty(ref _lastSmartParams, value);
		}

		[Ordinal(73)] 
		[RED("smartGunData")] 
		public CHandle<gamesmartGunUIParameters> SmartGunData
		{
			get => GetProperty(ref _smartGunData);
			set => SetProperty(ref _smartGunData, value);
		}

		[Ordinal(74)] 
		[RED("targetList")] 
		public CArray<gamesmartGunUITargetParameters> TargetList
		{
			get => GetProperty(ref _targetList);
			set => SetProperty(ref _targetList, value);
		}

		[Ordinal(75)] 
		[RED("targetData")] 
		public gamesmartGunUITargetParameters TargetData
		{
			get => GetProperty(ref _targetData);
			set => SetProperty(ref _targetData, value);
		}

		[Ordinal(76)] 
		[RED("numOfTargets")] 
		public CInt32 NumOfTargets
		{
			get => GetProperty(ref _numOfTargets);
			set => SetProperty(ref _numOfTargets, value);
		}

		[Ordinal(77)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public CrosshairGameController_BlackwallForce(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
