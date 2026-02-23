using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkBlackwallEffect : inkGlitchEffect
	{
		private CFloat _scaleX;
		private CFloat _scaleY;
		private CFloat _layerVisibility;

		[Ordinal(7)] 
		[RED("scaleX")] 
		public CFloat ScaleX
		{
			get => GetProperty(ref _scaleX);
			set => SetProperty(ref _scaleX, value);
		}

		[Ordinal(8)] 
		[RED("scaleY")] 
		public CFloat ScaleY
		{
			get => GetProperty(ref _scaleY);
			set => SetProperty(ref _scaleY, value);
		}

		[Ordinal(9)] 
		[RED("layerVisibility")] 
		public CFloat LayerVisibility
		{
			get => GetProperty(ref _layerVisibility);
			set => SetProperty(ref _layerVisibility, value);
		}

		public inkBlackwallEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
