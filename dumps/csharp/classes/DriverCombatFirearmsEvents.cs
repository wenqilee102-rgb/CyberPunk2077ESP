using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DriverCombatFirearmsEvents : DriverCombatEvents
	{
		private CHandle<gameAttachmentSlotsScriptListener> _attachmentSlotListener;
		private CHandle<AnimFeature_ProceduralDriverCombatData> _posAnimFeature;
		private CHandle<gamedataVehicle_Record> _vehicleRecord;
		private EulerAngles _angleDelta;
		private EulerAngles _localOrientation;
		private CEnum<gamedataItemType> _updateItemType;
		private CHandle<redCallbackObject> _photoModeActiveListener;
		private CBool _isPhotoModeActive;
		private CFloat _minSwaySpeed;
		private CFloat _prevSpeed;

		[Ordinal(20)] 
		[RED("attachmentSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> AttachmentSlotListener
		{
			get => GetProperty(ref _attachmentSlotListener);
			set => SetProperty(ref _attachmentSlotListener, value);
		}

		[Ordinal(21)] 
		[RED("posAnimFeature")] 
		public CHandle<AnimFeature_ProceduralDriverCombatData> PosAnimFeature
		{
			get => GetProperty(ref _posAnimFeature);
			set => SetProperty(ref _posAnimFeature, value);
		}

		[Ordinal(22)] 
		[RED("vehicleRecord")] 
		public CHandle<gamedataVehicle_Record> VehicleRecord
		{
			get => GetProperty(ref _vehicleRecord);
			set => SetProperty(ref _vehicleRecord, value);
		}

		[Ordinal(23)] 
		[RED("angleDelta")] 
		public EulerAngles AngleDelta
		{
			get => GetProperty(ref _angleDelta);
			set => SetProperty(ref _angleDelta, value);
		}

		[Ordinal(24)] 
		[RED("localOrientation")] 
		public EulerAngles LocalOrientation
		{
			get => GetProperty(ref _localOrientation);
			set => SetProperty(ref _localOrientation, value);
		}

		[Ordinal(25)] 
		[RED("updateItemType")] 
		public CEnum<gamedataItemType> UpdateItemType
		{
			get => GetProperty(ref _updateItemType);
			set => SetProperty(ref _updateItemType, value);
		}

		[Ordinal(26)] 
		[RED("photoModeActiveListener")] 
		public CHandle<redCallbackObject> PhotoModeActiveListener
		{
			get => GetProperty(ref _photoModeActiveListener);
			set => SetProperty(ref _photoModeActiveListener, value);
		}

		[Ordinal(27)] 
		[RED("isPhotoModeActive")] 
		public CBool IsPhotoModeActive
		{
			get => GetProperty(ref _isPhotoModeActive);
			set => SetProperty(ref _isPhotoModeActive, value);
		}

		[Ordinal(28)] 
		[RED("minSwaySpeed")] 
		public CFloat MinSwaySpeed
		{
			get => GetProperty(ref _minSwaySpeed);
			set => SetProperty(ref _minSwaySpeed, value);
		}

		[Ordinal(29)] 
		[RED("prevSpeed")] 
		public CFloat PrevSpeed
		{
			get => GetProperty(ref _prevSpeed);
			set => SetProperty(ref _prevSpeed, value);
		}

		public DriverCombatFirearmsEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
