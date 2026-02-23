using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimapLayerHighlightRequest : CVariable
	{
		private CEnum<minimapuiELayerType> _layer;
		private minimapLayerHighlightRequestData _data;

		[Ordinal(0)] 
		[RED("layer")] 
		public CEnum<minimapuiELayerType> Layer
		{
			get => GetProperty(ref _layer);
			set => SetProperty(ref _layer, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public minimapLayerHighlightRequestData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public MinimapLayerHighlightRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
