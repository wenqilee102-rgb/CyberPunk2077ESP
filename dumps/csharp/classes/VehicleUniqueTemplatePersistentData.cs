using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleUniqueTemplatePersistentData : CVariable
	{
		private CName _modelName;
		private CArray<TweakDBID> _templatesID;

		[Ordinal(0)] 
		[RED("modelName")] 
		public CName ModelName
		{
			get => GetProperty(ref _modelName);
			set => SetProperty(ref _modelName, value);
		}

		[Ordinal(1)] 
		[RED("templatesID")] 
		public CArray<TweakDBID> TemplatesID
		{
			get => GetProperty(ref _templatesID);
			set => SetProperty(ref _templatesID, value);
		}

		public VehicleUniqueTemplatePersistentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
