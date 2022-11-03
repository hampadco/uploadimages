 //upload image
        if (product.File != null)
        {
            var uploadDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images");
            fileName = Guid.NewGuid().ToString() + "_" + product.File.FileName;
            var filePath = Path.Combine(uploadDir, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                product.File.CopyTo(fileStream);
            }
        }
