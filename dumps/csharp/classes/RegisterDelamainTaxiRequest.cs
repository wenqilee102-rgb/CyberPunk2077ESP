using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterDelamainTaxiRequest : gameScriptableSystemRequest
	{
		private wCHandle<DelamainTaxiComponent> _delamainTaxi;

		[Ordinal(0)] 
		[RED("delamainTaxi")] 
		public wCHandle<DelamainTaxiComponent> DelamainTaxi
		{
			get => GetProperty(ref _delamainTaxi);
			set => SetProperty(ref _delamainTaxi, value);
		}

		public RegisterDelamainTaxiRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
