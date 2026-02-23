using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class attrSlider : attrAttribute
	{
		private CFloat _ep;

		[Ordinal(0)] 
		[RED("ep")] 
		public CFloat Ep
		{
			get => GetProperty(ref _ep);
			set => SetProperty(ref _ep, value);
		}

		public attrSlider(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
