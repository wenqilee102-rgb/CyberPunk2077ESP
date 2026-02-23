using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ncartMetroObject : vehicleAVBaseObject
	{
		private gameDelayID _pitchAdjustmentDelayID;
		private CFloat _z;
		private CBool _checkForLeveling;
		private CInt32 _pitchingValue;
		private CFloat _pitchAngleCheckInterval;
		private CFloat _pitchAngleReturnInterval;
		private CName _trainReverseDirectionFactName;
		private CFloat _pitchAngleAdjustmentTreshold;
		private CFloat _pitchAngleLevelOutTreshold;

		[Ordinal(64)] 
		[RED("pitchAdjustmentDelayID")] 
		public gameDelayID PitchAdjustmentDelayID
		{
			get => GetProperty(ref _pitchAdjustmentDelayID);
			set => SetProperty(ref _pitchAdjustmentDelayID, value);
		}

		[Ordinal(65)] 
		[RED("Z")] 
		public CFloat Z
		{
			get => GetProperty(ref _z);
			set => SetProperty(ref _z, value);
		}

		[Ordinal(66)] 
		[RED("checkForLeveling")] 
		public CBool CheckForLeveling
		{
			get => GetProperty(ref _checkForLeveling);
			set => SetProperty(ref _checkForLeveling, value);
		}

		[Ordinal(67)] 
		[RED("pitchingValue")] 
		public CInt32 PitchingValue
		{
			get => GetProperty(ref _pitchingValue);
			set => SetProperty(ref _pitchingValue, value);
		}

		[Ordinal(68)] 
		[RED("pitchAngleCheckInterval")] 
		public CFloat PitchAngleCheckInterval
		{
			get => GetProperty(ref _pitchAngleCheckInterval);
			set => SetProperty(ref _pitchAngleCheckInterval, value);
		}

		[Ordinal(69)] 
		[RED("pitchAngleReturnInterval")] 
		public CFloat PitchAngleReturnInterval
		{
			get => GetProperty(ref _pitchAngleReturnInterval);
			set => SetProperty(ref _pitchAngleReturnInterval, value);
		}

		[Ordinal(70)] 
		[RED("trainReverseDirectionFactName")] 
		public CName TrainReverseDirectionFactName
		{
			get => GetProperty(ref _trainReverseDirectionFactName);
			set => SetProperty(ref _trainReverseDirectionFactName, value);
		}

		[Ordinal(71)] 
		[RED("pitchAngleAdjustmentTreshold")] 
		public CFloat PitchAngleAdjustmentTreshold
		{
			get => GetProperty(ref _pitchAngleAdjustmentTreshold);
			set => SetProperty(ref _pitchAngleAdjustmentTreshold, value);
		}

		[Ordinal(72)] 
		[RED("pitchAngleLevelOutTreshold")] 
		public CFloat PitchAngleLevelOutTreshold
		{
			get => GetProperty(ref _pitchAngleLevelOutTreshold);
			set => SetProperty(ref _pitchAngleLevelOutTreshold, value);
		}

		public ncartMetroObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
