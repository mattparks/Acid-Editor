set(EDITOR_HEADERS_
        "ImGui/imconfig.h"
        "ImGui/imgui.h"
        "ImGui/imgui_internal.h"
        "ImGui/stb_rect_pack.h"
        "ImGui/stb_textedit.h"
        "ImGui/stb_truetype.h"
		"MainRenderer.hpp"
		"MainUpdater.hpp"
		"Scenes/FpsCamera.hpp"
		"Scenes/FpsPlayer.hpp"
		"Scenes/Scene1.hpp"
		"Uis/OverlayDebug.hpp"
)

set(EDITOR_SOURCES_
        "ImGui/imgui.cpp"
        "ImGui/imgui_demo.cpp"
        "ImGui/imgui_draw.cpp"
		"Main.cpp"
		"MainRenderer.cpp"
		"MainUpdater.cpp"
		"Editor.rc"
		"Scenes/FpsCamera.cpp"
		"Scenes/FpsPlayer.cpp"
		"Scenes/Scene1.cpp"
		"Uis/OverlayDebug.cpp"
)

source_group("Header Files" FILES ${EDITOR_HEADERS_})
source_group("Source Files" FILES ${EDITOR_SOURCES_})

set(EDITOR_SOURCES
		${EDITOR_HEADERS_}
		${EDITOR_SOURCES_}
)
