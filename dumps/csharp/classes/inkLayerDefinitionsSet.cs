using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLayerDefinitionsSet : CVariable
	{
		private CArray<inkLayerDefinition_NEW> _layersDefinitions;
		private CArray<inkLayerSystemConnection> _layersSystemConnections;

		[Ordinal(0)] 
		[RED("layersDefinitions")] 
		public CArray<inkLayerDefinition_NEW> LayersDefinitions
		{
			get => GetProperty(ref _layersDefinitions);
			set => SetProperty(ref _layersDefinitions, value);
		}

		[Ordinal(1)] 
		[RED("layersSystemConnections")] 
		public CArray<inkLayerSystemConnection> LayersSystemConnections
		{
			get => GetProperty(ref _layersSystemConnections);
			set => SetProperty(ref _layersSystemConnections, value);
		}

		public inkLayerDefinitionsSet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
