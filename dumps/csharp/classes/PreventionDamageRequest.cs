using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionDamageRequest : gameScriptableSystemRequest
	{
		private CBool _isInternal;
		private CFloat _damageDealtPercentValue;
		private entEntityID _targetID;
		private Vector4 _targetPosition;
		private CBool _isTargetKilled;
		private CBool _isTargetPrevention;
		private CBool _isTargetVehicle;
		private CEnum<EPreventionHeatStage> _requestedHeat;
		private CEnum<gamedataAttackType> _attackType;
		private CString _telemetryInfo;

		[Ordinal(0)] 
		[RED("isInternal")] 
		public CBool IsInternal
		{
			get => GetProperty(ref _isInternal);
			set => SetProperty(ref _isInternal, value);
		}

		[Ordinal(1)] 
		[RED("damageDealtPercentValue")] 
		public CFloat DamageDealtPercentValue
		{
			get => GetProperty(ref _damageDealtPercentValue);
			set => SetProperty(ref _damageDealtPercentValue, value);
		}

		[Ordinal(2)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		[Ordinal(3)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(4)] 
		[RED("isTargetKilled")] 
		public CBool IsTargetKilled
		{
			get => GetProperty(ref _isTargetKilled);
			set => SetProperty(ref _isTargetKilled, value);
		}

		[Ordinal(5)] 
		[RED("isTargetPrevention")] 
		public CBool IsTargetPrevention
		{
			get => GetProperty(ref _isTargetPrevention);
			set => SetProperty(ref _isTargetPrevention, value);
		}

		[Ordinal(6)] 
		[RED("isTargetVehicle")] 
		public CBool IsTargetVehicle
		{
			get => GetProperty(ref _isTargetVehicle);
			set => SetProperty(ref _isTargetVehicle, value);
		}

		[Ordinal(7)] 
		[RED("requestedHeat")] 
		public CEnum<EPreventionHeatStage> RequestedHeat
		{
			get => GetProperty(ref _requestedHeat);
			set => SetProperty(ref _requestedHeat, value);
		}

		[Ordinal(8)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		[Ordinal(9)] 
		[RED("telemetryInfo")] 
		public CString TelemetryInfo
		{
			get => GetProperty(ref _telemetryInfo);
			set => SetProperty(ref _telemetryInfo, value);
		}

		public PreventionDamageRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
