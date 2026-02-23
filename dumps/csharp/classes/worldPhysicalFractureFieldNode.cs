using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPhysicalFractureFieldNode : worldNode
	{
		private physicsTriggerShape _shape;
		private physicsFractureFieldParams _fractureFieldParams;

		[Ordinal(4)] 
		[RED("shape")] 
		public physicsTriggerShape Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}

		[Ordinal(5)] 
		[RED("fractureFieldParams")] 
		public physicsFractureFieldParams FractureFieldParams
		{
			get => GetProperty(ref _fractureFieldParams);
			set => SetProperty(ref _fractureFieldParams, value);
		}

		public worldPhysicalFractureFieldNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
