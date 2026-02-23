using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HotkeysWidgetController : gameuiNewPhoneRelatedHUDGameController
	{
		private inkCompoundWidgetReference _phoneSlot;
		private inkCompoundWidgetReference _carSlot;
		private inkCompoundWidgetReference _radioSlot;
		private inkCompoundWidgetReference _dpadHintsPanel;
		private wCHandle<inkWidget> _phone;
		private wCHandle<inkWidget> _car;
		private wCHandle<inkWidget> _radio;
		private wCHandle<inkWidget> _consumables;
		private wCHandle<inkWidget> _gadgets;
		private wCHandle<inkWidget> _cyberware;
		private wCHandle<inkWidget> _leeroy;
		private wCHandle<inkWidget> _timeBank;
		private CHandle<redCallbackObject> _berserkEnabledBBId;

		[Ordinal(15)] 
		[RED("phoneSlot")] 
		public inkCompoundWidgetReference PhoneSlot
		{
			get => GetProperty(ref _phoneSlot);
			set => SetProperty(ref _phoneSlot, value);
		}

		[Ordinal(16)] 
		[RED("carSlot")] 
		public inkCompoundWidgetReference CarSlot
		{
			get => GetProperty(ref _carSlot);
			set => SetProperty(ref _carSlot, value);
		}

		[Ordinal(17)] 
		[RED("radioSlot")] 
		public inkCompoundWidgetReference RadioSlot
		{
			get => GetProperty(ref _radioSlot);
			set => SetProperty(ref _radioSlot, value);
		}

		[Ordinal(18)] 
		[RED("dpadHintsPanel")] 
		public inkCompoundWidgetReference DpadHintsPanel
		{
			get => GetProperty(ref _dpadHintsPanel);
			set => SetProperty(ref _dpadHintsPanel, value);
		}

		[Ordinal(19)] 
		[RED("phone")] 
		public wCHandle<inkWidget> Phone
		{
			get => GetProperty(ref _phone);
			set => SetProperty(ref _phone, value);
		}

		[Ordinal(20)] 
		[RED("car")] 
		public wCHandle<inkWidget> Car
		{
			get => GetProperty(ref _car);
			set => SetProperty(ref _car, value);
		}

		[Ordinal(21)] 
		[RED("radio")] 
		public wCHandle<inkWidget> Radio
		{
			get => GetProperty(ref _radio);
			set => SetProperty(ref _radio, value);
		}

		[Ordinal(22)] 
		[RED("consumables")] 
		public wCHandle<inkWidget> Consumables
		{
			get => GetProperty(ref _consumables);
			set => SetProperty(ref _consumables, value);
		}

		[Ordinal(23)] 
		[RED("gadgets")] 
		public wCHandle<inkWidget> Gadgets
		{
			get => GetProperty(ref _gadgets);
			set => SetProperty(ref _gadgets, value);
		}

		[Ordinal(24)] 
		[RED("cyberware")] 
		public wCHandle<inkWidget> Cyberware
		{
			get => GetProperty(ref _cyberware);
			set => SetProperty(ref _cyberware, value);
		}

		[Ordinal(25)] 
		[RED("leeroy")] 
		public wCHandle<inkWidget> Leeroy
		{
			get => GetProperty(ref _leeroy);
			set => SetProperty(ref _leeroy, value);
		}

		[Ordinal(26)] 
		[RED("timeBank")] 
		public wCHandle<inkWidget> TimeBank
		{
			get => GetProperty(ref _timeBank);
			set => SetProperty(ref _timeBank, value);
		}

		[Ordinal(27)] 
		[RED("berserkEnabledBBId")] 
		public CHandle<redCallbackObject> BerserkEnabledBBId
		{
			get => GetProperty(ref _berserkEnabledBBId);
			set => SetProperty(ref _berserkEnabledBBId, value);
		}

		public HotkeysWidgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
