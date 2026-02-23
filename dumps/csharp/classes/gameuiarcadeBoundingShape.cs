using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeBoundingShape : IScriptable
	{
		private inkWidgetReference _boundingShape;

		[Ordinal(0)] 
		[RED("boundingShape")] 
		public inkWidgetReference BoundingShape
		{
			get => GetProperty(ref _boundingShape);
			set => SetProperty(ref _boundingShape, value);
		}

		public gameuiarcadeBoundingShape(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
