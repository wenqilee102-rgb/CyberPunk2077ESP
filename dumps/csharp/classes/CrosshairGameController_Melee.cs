using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Melee : gameuiCrosshairBaseMelee
	{
		private inkWidgetReference _targetColorChange;
		private wCHandle<inkCanvasWidget> _chargeBar;
		private wCHandle<inkRectangleWidget> _chargeBarFG;
		private wCHandle<inkImageWidget> _chargeBarMonoTop;
		private wCHandle<inkImageWidget> _chargeBarMonoBottom;
		private wCHandle<inkMaskWidget> _chargeBarMask;
		private wCHandle<inkTextWidget> _chargeValueL;
		private wCHandle<inkTextWidget> _chargeValueR;
		private CUInt32 _bbcharge;
		private CHandle<MeleeResourcePoolListener> _meleeResourcePoolListener;
		private entEntityID _weaponID;
		private CBool _displayChargeBar;
		private CInt32 _currentState;
		private CHandle<MeleeLeapAttackObjectTagger> _meleeLeapAttackObjectTagger;

		[Ordinal(30)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetProperty(ref _targetColorChange);
			set => SetProperty(ref _targetColorChange, value);
		}

		[Ordinal(31)] 
		[RED("chargeBar")] 
		public wCHandle<inkCanvasWidget> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}

		[Ordinal(32)] 
		[RED("chargeBarFG")] 
		public wCHandle<inkRectangleWidget> ChargeBarFG
		{
			get => GetProperty(ref _chargeBarFG);
			set => SetProperty(ref _chargeBarFG, value);
		}

		[Ordinal(33)] 
		[RED("chargeBarMonoTop")] 
		public wCHandle<inkImageWidget> ChargeBarMonoTop
		{
			get => GetProperty(ref _chargeBarMonoTop);
			set => SetProperty(ref _chargeBarMonoTop, value);
		}

		[Ordinal(34)] 
		[RED("chargeBarMonoBottom")] 
		public wCHandle<inkImageWidget> ChargeBarMonoBottom
		{
			get => GetProperty(ref _chargeBarMonoBottom);
			set => SetProperty(ref _chargeBarMonoBottom, value);
		}

		[Ordinal(35)] 
		[RED("chargeBarMask")] 
		public wCHandle<inkMaskWidget> ChargeBarMask
		{
			get => GetProperty(ref _chargeBarMask);
			set => SetProperty(ref _chargeBarMask, value);
		}

		[Ordinal(36)] 
		[RED("chargeValueL")] 
		public wCHandle<inkTextWidget> ChargeValueL
		{
			get => GetProperty(ref _chargeValueL);
			set => SetProperty(ref _chargeValueL, value);
		}

		[Ordinal(37)] 
		[RED("chargeValueR")] 
		public wCHandle<inkTextWidget> ChargeValueR
		{
			get => GetProperty(ref _chargeValueR);
			set => SetProperty(ref _chargeValueR, value);
		}

		[Ordinal(38)] 
		[RED("bbcharge")] 
		public CUInt32 Bbcharge
		{
			get => GetProperty(ref _bbcharge);
			set => SetProperty(ref _bbcharge, value);
		}

		[Ordinal(39)] 
		[RED("meleeResourcePoolListener")] 
		public CHandle<MeleeResourcePoolListener> MeleeResourcePoolListener
		{
			get => GetProperty(ref _meleeResourcePoolListener);
			set => SetProperty(ref _meleeResourcePoolListener, value);
		}

		[Ordinal(40)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		[Ordinal(41)] 
		[RED("displayChargeBar")] 
		public CBool DisplayChargeBar
		{
			get => GetProperty(ref _displayChargeBar);
			set => SetProperty(ref _displayChargeBar, value);
		}

		[Ordinal(42)] 
		[RED("currentState")] 
		public CInt32 CurrentState
		{
			get => GetProperty(ref _currentState);
			set => SetProperty(ref _currentState, value);
		}

		[Ordinal(43)] 
		[RED("meleeLeapAttackObjectTagger")] 
		public CHandle<MeleeLeapAttackObjectTagger> MeleeLeapAttackObjectTagger
		{
			get => GetProperty(ref _meleeLeapAttackObjectTagger);
			set => SetProperty(ref _meleeLeapAttackObjectTagger, value);
		}

		public CrosshairGameController_Melee(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
