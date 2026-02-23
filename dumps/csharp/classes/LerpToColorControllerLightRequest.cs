using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LerpToColorControllerLightRequest : gameScriptableSystemRequest
	{
		private Vector3 _rgb;
		private CFloat _timeToLerp;
		private CBool _useExponentialCurve;

		[Ordinal(0)] 
		[RED("rgb")] 
		public Vector3 Rgb
		{
			get => GetProperty(ref _rgb);
			set => SetProperty(ref _rgb, value);
		}

		[Ordinal(1)] 
		[RED("timeToLerp")] 
		public CFloat TimeToLerp
		{
			get => GetProperty(ref _timeToLerp);
			set => SetProperty(ref _timeToLerp, value);
		}

		[Ordinal(2)] 
		[RED("useExponentialCurve")] 
		public CBool UseExponentialCurve
		{
			get => GetProperty(ref _useExponentialCurve);
			set => SetProperty(ref _useExponentialCurve, value);
		}

		public LerpToColorControllerLightRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
