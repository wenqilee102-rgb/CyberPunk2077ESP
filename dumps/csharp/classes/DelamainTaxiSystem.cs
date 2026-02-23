using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelamainTaxiSystem : gameScriptableSystem
	{
		private CBool _isDelamainTaxiEnabledOnMap;
		private gameNewMappinID _delamainMappinID;
		private CInt32 _currentTravelCost;
		private CBool _hUDHidden;
		private wCHandle<DelamainTaxiComponent> _delamainTaxi;

		[Ordinal(0)] 
		[RED("isDelamainTaxiEnabledOnMap")] 
		public CBool IsDelamainTaxiEnabledOnMap
		{
			get => GetProperty(ref _isDelamainTaxiEnabledOnMap);
			set => SetProperty(ref _isDelamainTaxiEnabledOnMap, value);
		}

		[Ordinal(1)] 
		[RED("delamainMappinID")] 
		public gameNewMappinID DelamainMappinID
		{
			get => GetProperty(ref _delamainMappinID);
			set => SetProperty(ref _delamainMappinID, value);
		}

		[Ordinal(2)] 
		[RED("currentTravelCost")] 
		public CInt32 CurrentTravelCost
		{
			get => GetProperty(ref _currentTravelCost);
			set => SetProperty(ref _currentTravelCost, value);
		}

		[Ordinal(3)] 
		[RED("HUDHidden")] 
		public CBool HUDHidden
		{
			get => GetProperty(ref _hUDHidden);
			set => SetProperty(ref _hUDHidden, value);
		}

		[Ordinal(4)] 
		[RED("delamainTaxi")] 
		public wCHandle<DelamainTaxiComponent> DelamainTaxi
		{
			get => GetProperty(ref _delamainTaxi);
			set => SetProperty(ref _delamainTaxi, value);
		}

		public DelamainTaxiSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
