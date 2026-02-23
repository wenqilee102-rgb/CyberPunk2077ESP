using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSavedPatrolProgressState : ISerializable
	{
		private CFloat _entrySplineParam;
		private CUInt32 _entrySectionIndex;
		private CUInt32 _controlPointIndex;
		private Vector3 _splineEntryPosition;
		private Vector3 _splineEntryTangent;
		private CBool _isSplineReversed;
		private Vector3 _currentDestinationPosition;
		private Vector3 _currentDestinationTangent;

		[Ordinal(0)] 
		[RED("entrySplineParam")] 
		public CFloat EntrySplineParam
		{
			get => GetProperty(ref _entrySplineParam);
			set => SetProperty(ref _entrySplineParam, value);
		}

		[Ordinal(1)] 
		[RED("entrySectionIndex")] 
		public CUInt32 EntrySectionIndex
		{
			get => GetProperty(ref _entrySectionIndex);
			set => SetProperty(ref _entrySectionIndex, value);
		}

		[Ordinal(2)] 
		[RED("controlPointIndex")] 
		public CUInt32 ControlPointIndex
		{
			get => GetProperty(ref _controlPointIndex);
			set => SetProperty(ref _controlPointIndex, value);
		}

		[Ordinal(3)] 
		[RED("splineEntryPosition")] 
		public Vector3 SplineEntryPosition
		{
			get => GetProperty(ref _splineEntryPosition);
			set => SetProperty(ref _splineEntryPosition, value);
		}

		[Ordinal(4)] 
		[RED("splineEntryTangent")] 
		public Vector3 SplineEntryTangent
		{
			get => GetProperty(ref _splineEntryTangent);
			set => SetProperty(ref _splineEntryTangent, value);
		}

		[Ordinal(5)] 
		[RED("isSplineReversed")] 
		public CBool IsSplineReversed
		{
			get => GetProperty(ref _isSplineReversed);
			set => SetProperty(ref _isSplineReversed, value);
		}

		[Ordinal(6)] 
		[RED("currentDestinationPosition")] 
		public Vector3 CurrentDestinationPosition
		{
			get => GetProperty(ref _currentDestinationPosition);
			set => SetProperty(ref _currentDestinationPosition, value);
		}

		[Ordinal(7)] 
		[RED("currentDestinationTangent")] 
		public Vector3 CurrentDestinationTangent
		{
			get => GetProperty(ref _currentDestinationTangent);
			set => SetProperty(ref _currentDestinationTangent, value);
		}

		public gameSavedPatrolProgressState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
