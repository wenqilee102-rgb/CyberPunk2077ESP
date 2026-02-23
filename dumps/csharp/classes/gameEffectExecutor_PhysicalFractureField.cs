using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_PhysicalFractureField : gameEffectExecutor
	{
		private CBool _fromHitPosition;
		private physicsFractureFieldParams _fieldParams;
		private CEnum<physicsShapeType> _fieldShape;
		private Vector3 _fieldDimensions;

		[Ordinal(1)] 
		[RED("fromHitPosition")] 
		public CBool FromHitPosition
		{
			get => GetProperty(ref _fromHitPosition);
			set => SetProperty(ref _fromHitPosition, value);
		}

		[Ordinal(2)] 
		[RED("fieldParams")] 
		public physicsFractureFieldParams FieldParams
		{
			get => GetProperty(ref _fieldParams);
			set => SetProperty(ref _fieldParams, value);
		}

		[Ordinal(3)] 
		[RED("fieldShape")] 
		public CEnum<physicsShapeType> FieldShape
		{
			get => GetProperty(ref _fieldShape);
			set => SetProperty(ref _fieldShape, value);
		}

		[Ordinal(4)] 
		[RED("fieldDimensions")] 
		public Vector3 FieldDimensions
		{
			get => GetProperty(ref _fieldDimensions);
			set => SetProperty(ref _fieldDimensions, value);
		}

		public gameEffectExecutor_PhysicalFractureField(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
