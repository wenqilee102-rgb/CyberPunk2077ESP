using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FindTeleportPositionKurt : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _extents;
		private CHandle<AIArgumentMapping> _extentsOffset;
		private CHandle<AIArgumentMapping> _workspotRotation;
		private CHandle<AIArgumentMapping> _workspotOffset;
		private CHandle<AIArgumentMapping> _outPositionArgument;
		private CHandle<AIArgumentMapping> _outRotationArgument;
		private CHandle<AIArgumentMapping> _outMaybeStairs;

		[Ordinal(0)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("extents")] 
		public CHandle<AIArgumentMapping> Extents
		{
			get => GetProperty(ref _extents);
			set => SetProperty(ref _extents, value);
		}

		[Ordinal(2)] 
		[RED("extentsOffset")] 
		public CHandle<AIArgumentMapping> ExtentsOffset
		{
			get => GetProperty(ref _extentsOffset);
			set => SetProperty(ref _extentsOffset, value);
		}

		[Ordinal(3)] 
		[RED("workspotRotation")] 
		public CHandle<AIArgumentMapping> WorkspotRotation
		{
			get => GetProperty(ref _workspotRotation);
			set => SetProperty(ref _workspotRotation, value);
		}

		[Ordinal(4)] 
		[RED("workspotOffset")] 
		public CHandle<AIArgumentMapping> WorkspotOffset
		{
			get => GetProperty(ref _workspotOffset);
			set => SetProperty(ref _workspotOffset, value);
		}

		[Ordinal(5)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get => GetProperty(ref _outPositionArgument);
			set => SetProperty(ref _outPositionArgument, value);
		}

		[Ordinal(6)] 
		[RED("outRotationArgument")] 
		public CHandle<AIArgumentMapping> OutRotationArgument
		{
			get => GetProperty(ref _outRotationArgument);
			set => SetProperty(ref _outRotationArgument, value);
		}

		[Ordinal(7)] 
		[RED("outMaybeStairs")] 
		public CHandle<AIArgumentMapping> OutMaybeStairs
		{
			get => GetProperty(ref _outMaybeStairs);
			set => SetProperty(ref _outMaybeStairs, value);
		}

		public FindTeleportPositionKurt(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
