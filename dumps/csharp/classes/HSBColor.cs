using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HSBColor : CVariable
	{
		private CFloat _hue;
		private CFloat _saturation;
		private CFloat _brightness;

		[Ordinal(0)] 
		[RED("Hue")] 
		public CFloat Hue
		{
			get => GetProperty(ref _hue);
			set => SetProperty(ref _hue, value);
		}

		[Ordinal(1)] 
		[RED("Saturation")] 
		public CFloat Saturation
		{
			get => GetProperty(ref _saturation);
			set => SetProperty(ref _saturation, value);
		}

		[Ordinal(2)] 
		[RED("Brightness")] 
		public CFloat Brightness
		{
			get => GetProperty(ref _brightness);
			set => SetProperty(ref _brightness, value);
		}

		public HSBColor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
