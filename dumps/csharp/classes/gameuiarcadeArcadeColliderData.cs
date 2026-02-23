using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeArcadeColliderData : CVariable
	{
		private CEnum<gameuiarcadeArcadeColliderType> _type;
		private CHandle<gameuiarcadeBoundingShape> _shape;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameuiarcadeArcadeColliderType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("shape")] 
		public CHandle<gameuiarcadeBoundingShape> Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}

		public gameuiarcadeArcadeColliderData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
