using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redTaskNameMessage : CVariable
	{
		private CUInt32 _id;
		private CUInt32 _parent;
		private CString _title;
		private CName _uniqueName;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("parent")] 
		public CUInt32 Parent
		{
			get => GetProperty(ref _parent);
			set => SetProperty(ref _parent, value);
		}

		[Ordinal(2)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(3)] 
		[RED("uniqueName")] 
		public CName UniqueName
		{
			get => GetProperty(ref _uniqueName);
			set => SetProperty(ref _uniqueName, value);
		}

		public redTaskNameMessage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
