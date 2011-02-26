﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Terse;
using Terse.Json;

public partial class ajax_song : LibraryAjax
{
	protected override string LibraryResponse(Library library) {
		int id = int.Parse(Request.QueryString["id"]);
		Song song;
		if (library.TryGetSong(id, out song)) {
			return song.ToJson().ToString();
		}
		return null;
	}
}