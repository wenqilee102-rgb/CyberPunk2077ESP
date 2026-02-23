using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioStationListItemController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _typeIcon;
		private inkHorizontalPanelWidgetReference _equilizerIcon;
		private inkImageWidgetReference _codeTLicon;
		private CHandle<RadioListItemData> _stationData;
		private CInt32 _currentRadioStationId;

		[Ordinal(18)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(19)] 
		[RED("typeIcon")] 
		public inkImageWidgetReference TypeIcon
		{
			get => GetProperty(ref _typeIcon);
			set => SetProperty(ref _typeIcon, value);
		}

		[Ordinal(20)] 
		[RED("equilizerIcon")] 
		public inkHorizontalPanelWidgetReference EquilizerIcon
		{
			get => GetProperty(ref _equilizerIcon);
			set => SetProperty(ref _equilizerIcon, value);
		}

		[Ordinal(21)] 
		[RED("codeTLicon")] 
		public inkImageWidgetReference CodeTLicon
		{
			get => GetProperty(ref _codeTLicon);
			set => SetProperty(ref _codeTLicon, value);
		}

		[Ordinal(22)] 
		[RED("stationData")] 
		public CHandle<RadioListItemData> StationData
		{
			get => GetProperty(ref _stationData);
			set => SetProperty(ref _stationData, value);
		}

		[Ordinal(23)] 
		[RED("currentRadioStationId")] 
		public CInt32 CurrentRadioStationId
		{
			get => GetProperty(ref _currentRadioStationId);
			set => SetProperty(ref _currentRadioStationId, value);
		}

		public RadioStationListItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
