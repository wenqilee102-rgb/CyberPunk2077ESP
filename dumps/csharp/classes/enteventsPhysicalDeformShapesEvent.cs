using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsPhysicalDeformShapesEvent : redEvent
	{
		private CArray<CInt32> _shapes;
		private CFloat _value;

		[Ordinal(0)] 
		[RED("shapes")] 
		public CArray<CInt32> Shapes
		{
			get => GetProperty(ref _shapes);
			set => SetProperty(ref _shapes, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public enteventsPhysicalDeformShapesEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
