using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemWeaponBar : IScriptable
	{
		private CFloat _value;
		private CFloat _maxValue;
		private CFloat _percentage;
		private CEnum<WeaponBarType> _type;
		private CBool _isValueSet;

		[Ordinal(0)] 
		[RED("Value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("MaxValue")] 
		public CFloat MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(2)] 
		[RED("Percentage")] 
		public CFloat Percentage
		{
			get => GetProperty(ref _percentage);
			set => SetProperty(ref _percentage, value);
		}

		[Ordinal(3)] 
		[RED("Type")] 
		public CEnum<WeaponBarType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("isValueSet")] 
		public CBool IsValueSet
		{
			get => GetProperty(ref _isValueSet);
			set => SetProperty(ref _isValueSet, value);
		}

		public UIInventoryItemWeaponBar(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
