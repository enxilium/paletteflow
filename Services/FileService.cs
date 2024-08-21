using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using paletteflow.Models;

namespace paletteflow.Services
{
    public static class FileService
    {
        private static readonly string FilePath = "palettes.json";

        public static void SavePalettes(List<Palette> palettes)
        {
            var json = JsonSerializer.Serialize(palettes);
            File.WriteAllText(FilePath, json);
        }

        public static List<Palette> LoadPalettes()
        {
            if (!File.Exists(FilePath))
                return new List<Palette>();

            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Palette>>(json);
        }

        public static void RemovePalette(Palette paletteToRemove)
        {
            var palettes = LoadPalettes();
            var palette = palettes.FirstOrDefault(p => p.Id == paletteToRemove.Id);
            if (palette != null)
            {
                palettes.Remove(palette);
                SavePalettes(palettes);
            }
        }

        public static void UpdatePalette(Palette paletteToUpdate)
        {
            var palettes = LoadPalettes();
            var index = palettes.FindIndex(p => p.Id == paletteToUpdate.Id);
            if (index != -1)
            {
                palettes[index] = paletteToUpdate;
                SavePalettes(palettes);
            }
        }

        public static void ClearPalettes() // Method to clear saved palettes, testing purposes
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }
    }
}