using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVehicleDecalAttachmentData : CVariable
	{
		private CName _componentToAttachTo;
		private redResourceReferenceScriptToken _decalReference;

		[Ordinal(0)] 
		[RED("componentToAttachTo")] 
		public CName ComponentToAttachTo
		{
			get => GetProperty(ref _componentToAttachTo);
			set => SetProperty(ref _componentToAttachTo, value);
		}

		[Ordinal(1)] 
		[RED("decalReference")] 
		public redResourceReferenceScriptToken DecalReference
		{
			get => GetProperty(ref _decalReference);
			set => SetProperty(ref _decalReference, value);
		}

		public vehicleVehicleDecalAttachmentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
