using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageDigitsGameController : gameuiProjectedHUDGameController
	{
		private CInt32 _maxVisible;
		private CInt32 _maxAccumulatedVisible;
		private wCHandle<gameObject> _realOwner;
		private CHandle<inkScriptFIFOQueue> _digitsQueue;
		private CArray<wCHandle<DamageDigitLogicController>> _individualControllerArray;
		private CArray<AccumulatedDamageDigitsNode> _accumulatedControllerArray;
		private CBool _showDigitsIndividual;
		private CBool _showDigitsAccumulated;
		private CEnum<gameuiDamageDigitsStickingMode> _damageDigitsStickingMode;
		private CInt32 _spawnedDigits;
		private CHandle<redCallbackObject> _damageListBlackboardId;
		private CHandle<redCallbackObject> _damageDigitsModeBlackboardId;
		private CHandle<redCallbackObject> _damageDigitsStickingModeBlackboardId;

		[Ordinal(9)] 
		[RED("maxVisible")] 
		public CInt32 MaxVisible
		{
			get => GetProperty(ref _maxVisible);
			set => SetProperty(ref _maxVisible, value);
		}

		[Ordinal(10)] 
		[RED("maxAccumulatedVisible")] 
		public CInt32 MaxAccumulatedVisible
		{
			get => GetProperty(ref _maxAccumulatedVisible);
			set => SetProperty(ref _maxAccumulatedVisible, value);
		}

		[Ordinal(11)] 
		[RED("realOwner")] 
		public wCHandle<gameObject> RealOwner
		{
			get => GetProperty(ref _realOwner);
			set => SetProperty(ref _realOwner, value);
		}

		[Ordinal(12)] 
		[RED("digitsQueue")] 
		public CHandle<inkScriptFIFOQueue> DigitsQueue
		{
			get => GetProperty(ref _digitsQueue);
			set => SetProperty(ref _digitsQueue, value);
		}

		[Ordinal(13)] 
		[RED("individualControllerArray")] 
		public CArray<wCHandle<DamageDigitLogicController>> IndividualControllerArray
		{
			get => GetProperty(ref _individualControllerArray);
			set => SetProperty(ref _individualControllerArray, value);
		}

		[Ordinal(14)] 
		[RED("accumulatedControllerArray")] 
		public CArray<AccumulatedDamageDigitsNode> AccumulatedControllerArray
		{
			get => GetProperty(ref _accumulatedControllerArray);
			set => SetProperty(ref _accumulatedControllerArray, value);
		}

		[Ordinal(15)] 
		[RED("showDigitsIndividual")] 
		public CBool ShowDigitsIndividual
		{
			get => GetProperty(ref _showDigitsIndividual);
			set => SetProperty(ref _showDigitsIndividual, value);
		}

		[Ordinal(16)] 
		[RED("showDigitsAccumulated")] 
		public CBool ShowDigitsAccumulated
		{
			get => GetProperty(ref _showDigitsAccumulated);
			set => SetProperty(ref _showDigitsAccumulated, value);
		}

		[Ordinal(17)] 
		[RED("damageDigitsStickingMode")] 
		public CEnum<gameuiDamageDigitsStickingMode> DamageDigitsStickingMode
		{
			get => GetProperty(ref _damageDigitsStickingMode);
			set => SetProperty(ref _damageDigitsStickingMode, value);
		}

		[Ordinal(18)] 
		[RED("spawnedDigits")] 
		public CInt32 SpawnedDigits
		{
			get => GetProperty(ref _spawnedDigits);
			set => SetProperty(ref _spawnedDigits, value);
		}

		[Ordinal(19)] 
		[RED("damageListBlackboardId")] 
		public CHandle<redCallbackObject> DamageListBlackboardId
		{
			get => GetProperty(ref _damageListBlackboardId);
			set => SetProperty(ref _damageListBlackboardId, value);
		}

		[Ordinal(20)] 
		[RED("damageDigitsModeBlackboardId")] 
		public CHandle<redCallbackObject> DamageDigitsModeBlackboardId
		{
			get => GetProperty(ref _damageDigitsModeBlackboardId);
			set => SetProperty(ref _damageDigitsModeBlackboardId, value);
		}

		[Ordinal(21)] 
		[RED("damageDigitsStickingModeBlackboardId")] 
		public CHandle<redCallbackObject> DamageDigitsStickingModeBlackboardId
		{
			get => GetProperty(ref _damageDigitsStickingModeBlackboardId);
			set => SetProperty(ref _damageDigitsStickingModeBlackboardId, value);
		}

		public DamageDigitsGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
