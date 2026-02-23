using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFreeCameraLightSettings : CVariable
	{
		private Vector3 _s;
		private CFloat _dius;
		private CFloat _tensity;
		private CFloat _mperature;
		private Vector4 _lor;

		[Ordinal(0)] 
		[RED("s")] 
		public Vector3 S
		{
			get => GetProperty(ref _s);
			set => SetProperty(ref _s, value);
		}

		[Ordinal(1)] 
		[RED("dius")] 
		public CFloat Dius
		{
			get => GetProperty(ref _dius);
			set => SetProperty(ref _dius, value);
		}

		[Ordinal(2)] 
		[RED("tensity")] 
		public CFloat Tensity
		{
			get => GetProperty(ref _tensity);
			set => SetProperty(ref _tensity, value);
		}

		[Ordinal(3)] 
		[RED("mperature")] 
		public CFloat Mperature
		{
			get => GetProperty(ref _mperature);
			set => SetProperty(ref _mperature, value);
		}

		[Ordinal(4)] 
		[RED("lor")] 
		public Vector4 Lor
		{
			get => GetProperty(ref _lor);
			set => SetProperty(ref _lor, value);
		}

		public gameFreeCameraLightSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
