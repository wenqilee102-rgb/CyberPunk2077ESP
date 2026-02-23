using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsFractureFieldParams : CVariable
	{
		private Vector3 _origin;
		private CFloat _fractureFieldValue;
		private CEnum<physicsDestructionType> _destructionTypeMask;
		private CEnum<physicsFractureFieldType> _fractureFieldTypeMask;
		private CEnum<physicsFractureFieldOptions> _fractureFieldOptionsMask;
		private CEnum<physicsFractureFieldEffect> _fractureFieldEffect;
		private CEnum<physicsFractureFieldValueType> _fractureFieldValueType;

		[Ordinal(0)] 
		[RED("origin")] 
		public Vector3 Origin
		{
			get => GetProperty(ref _origin);
			set => SetProperty(ref _origin, value);
		}

		[Ordinal(1)] 
		[RED("fractureFieldValue")] 
		public CFloat FractureFieldValue
		{
			get => GetProperty(ref _fractureFieldValue);
			set => SetProperty(ref _fractureFieldValue, value);
		}

		[Ordinal(2)] 
		[RED("destructionTypeMask")] 
		public CEnum<physicsDestructionType> DestructionTypeMask
		{
			get => GetProperty(ref _destructionTypeMask);
			set => SetProperty(ref _destructionTypeMask, value);
		}

		[Ordinal(3)] 
		[RED("fractureFieldTypeMask")] 
		public CEnum<physicsFractureFieldType> FractureFieldTypeMask
		{
			get => GetProperty(ref _fractureFieldTypeMask);
			set => SetProperty(ref _fractureFieldTypeMask, value);
		}

		[Ordinal(4)] 
		[RED("fractureFieldOptionsMask")] 
		public CEnum<physicsFractureFieldOptions> FractureFieldOptionsMask
		{
			get => GetProperty(ref _fractureFieldOptionsMask);
			set => SetProperty(ref _fractureFieldOptionsMask, value);
		}

		[Ordinal(5)] 
		[RED("fractureFieldEffect")] 
		public CEnum<physicsFractureFieldEffect> FractureFieldEffect
		{
			get => GetProperty(ref _fractureFieldEffect);
			set => SetProperty(ref _fractureFieldEffect, value);
		}

		[Ordinal(6)] 
		[RED("fractureFieldValueType")] 
		public CEnum<physicsFractureFieldValueType> FractureFieldValueType
		{
			get => GetProperty(ref _fractureFieldValueType);
			set => SetProperty(ref _fractureFieldValueType, value);
		}

		public physicsFractureFieldParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
