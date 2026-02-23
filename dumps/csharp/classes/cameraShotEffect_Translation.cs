using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cameraShotEffect_Translation : vehicleTimedCinematicCameraShotEffect
	{
		private CName _movementCurve;
		private Transform _targetTransform;
		private cameraShotEffect_TranslationAffectedAxis _affectedAxisPosition;
		private CBool _ignoreRotation;
		private Transform _startTransformShotSpace;

		[Ordinal(3)] 
		[RED("movementCurve")] 
		public CName MovementCurve
		{
			get => GetProperty(ref _movementCurve);
			set => SetProperty(ref _movementCurve, value);
		}

		[Ordinal(4)] 
		[RED("targetTransform")] 
		public Transform TargetTransform
		{
			get => GetProperty(ref _targetTransform);
			set => SetProperty(ref _targetTransform, value);
		}

		[Ordinal(5)] 
		[RED("affectedAxisPosition")] 
		public cameraShotEffect_TranslationAffectedAxis AffectedAxisPosition
		{
			get => GetProperty(ref _affectedAxisPosition);
			set => SetProperty(ref _affectedAxisPosition, value);
		}

		[Ordinal(6)] 
		[RED("ignoreRotation")] 
		public CBool IgnoreRotation
		{
			get => GetProperty(ref _ignoreRotation);
			set => SetProperty(ref _ignoreRotation, value);
		}

		[Ordinal(7)] 
		[RED("startTransformShotSpace")] 
		public Transform StartTransformShotSpace
		{
			get => GetProperty(ref _startTransformShotSpace);
			set => SetProperty(ref _startTransformShotSpace, value);
		}

		public cameraShotEffect_Translation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
