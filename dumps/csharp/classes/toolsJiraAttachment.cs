using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraAttachment : CVariable
	{
		private CString _id;
		private CString _filename;
		private CString _content;
		private CString _thumbnail;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("filename")] 
		public CString Filename
		{
			get => GetProperty(ref _filename);
			set => SetProperty(ref _filename, value);
		}

		[Ordinal(2)] 
		[RED("content")] 
		public CString Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}

		[Ordinal(3)] 
		[RED("thumbnail")] 
		public CString Thumbnail
		{
			get => GetProperty(ref _thumbnail);
			set => SetProperty(ref _thumbnail, value);
		}

		public toolsJiraAttachment(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
