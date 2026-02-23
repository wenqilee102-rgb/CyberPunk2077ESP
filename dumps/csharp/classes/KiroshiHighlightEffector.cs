using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KiroshiHighlightEffector : HighlightEffector
	{
		private CBool _onlyWhileAiming;
		private CBool _onlyClosestToCrosshair;
		private CBool _onlyClosestByDistance;
		private CHandle<KiroshiEffectorIsAimingStatListener> _aimingStatListener;
		private CHandle<KiroshiEffectorTechPreviewStatListener> _techPreviewStatListener;
		private CHandle<KiroshiHighlightEffectorCallback> _slotCallback;
		private CHandle<gameAttachmentSlotsScriptListener> _slotListener;
		private CBool _isAiming;
		private CBool _isTechWeaponEquipped;
		private CBool _isMeleeWeaponEquipped;
		private CBool _isTechPreviewEnabled;

		[Ordinal(6)] 
		[RED("onlyWhileAiming")] 
		public CBool OnlyWhileAiming
		{
			get => GetProperty(ref _onlyWhileAiming);
			set => SetProperty(ref _onlyWhileAiming, value);
		}

		[Ordinal(7)] 
		[RED("onlyClosestToCrosshair")] 
		public CBool OnlyClosestToCrosshair
		{
			get => GetProperty(ref _onlyClosestToCrosshair);
			set => SetProperty(ref _onlyClosestToCrosshair, value);
		}

		[Ordinal(8)] 
		[RED("onlyClosestByDistance")] 
		public CBool OnlyClosestByDistance
		{
			get => GetProperty(ref _onlyClosestByDistance);
			set => SetProperty(ref _onlyClosestByDistance, value);
		}

		[Ordinal(9)] 
		[RED("aimingStatListener")] 
		public CHandle<KiroshiEffectorIsAimingStatListener> AimingStatListener
		{
			get => GetProperty(ref _aimingStatListener);
			set => SetProperty(ref _aimingStatListener, value);
		}

		[Ordinal(10)] 
		[RED("techPreviewStatListener")] 
		public CHandle<KiroshiEffectorTechPreviewStatListener> TechPreviewStatListener
		{
			get => GetProperty(ref _techPreviewStatListener);
			set => SetProperty(ref _techPreviewStatListener, value);
		}

		[Ordinal(11)] 
		[RED("slotCallback")] 
		public CHandle<KiroshiHighlightEffectorCallback> SlotCallback
		{
			get => GetProperty(ref _slotCallback);
			set => SetProperty(ref _slotCallback, value);
		}

		[Ordinal(12)] 
		[RED("slotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> SlotListener
		{
			get => GetProperty(ref _slotListener);
			set => SetProperty(ref _slotListener, value);
		}

		[Ordinal(13)] 
		[RED("IsAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		[Ordinal(14)] 
		[RED("isTechWeaponEquipped")] 
		public CBool IsTechWeaponEquipped
		{
			get => GetProperty(ref _isTechWeaponEquipped);
			set => SetProperty(ref _isTechWeaponEquipped, value);
		}

		[Ordinal(15)] 
		[RED("isMeleeWeaponEquipped")] 
		public CBool IsMeleeWeaponEquipped
		{
			get => GetProperty(ref _isMeleeWeaponEquipped);
			set => SetProperty(ref _isMeleeWeaponEquipped, value);
		}

		[Ordinal(16)] 
		[RED("isTechPreviewEnabled")] 
		public CBool IsTechPreviewEnabled
		{
			get => GetProperty(ref _isTechPreviewEnabled);
			set => SetProperty(ref _isTechPreviewEnabled, value);
		}

		public KiroshiHighlightEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
