using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace AdministradorPcOne.Servicios
{
    class CatalogoServicio
    {
        /* CRUD */
        public Task<List<Producto>> ObtenerProductosAsync(string param)
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities())
                {
                 List<Producto> Productos = new List<Producto>();
                    try { 
                         Productos = (from producto in db.Producto.Include("Categoria")
                                     where producto.nombre.Contains(param)
                                     select producto).ToList();
                         return Productos;
                    }
                    catch (Exception e)
                    {
                        Productos = null;
                        return Productos;
                    }
                }
            });
        }
        public Task<Producto> ObtenerProductoAsync(int id)
        {
            return Task.Run(() =>
            {
                DSPEntities db = new DSPEntities();
                    try
                    {
                        return db.Producto.Find(id);

                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                
            });
        }
        public Task<bool> EliminarProductoAsync(int id)
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities()) {
                    try { 
                        Producto ToDelete = db.Producto.Find(id);
                        db.Producto.Remove(ToDelete);
                        db.SaveChanges();
                        return true;
                    }
                    catch(Exception e){
                        
                        return false;
                    }
                }
            });
        }
        public Task<string[]> ObtenerCategorias()
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities())
                {
                    try
                    {
                        return (from data in db.Categoria
                                select data.nombre_categoria).ToArray();
                    }
                    catch (Exception e)
                    {
                        string[] array = new string[0];
                        return array;
                    }
                }
            });
        }
        public Task<bool> AgregarProductoAsync(Producto p)
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities())
                {
                    try
                    {
                        db.Producto.Add(p);
                        db.SaveChanges();
                        return true;
                    }
                    catch(Exception e)
                    {
                        return false;
                    }
                }
                    
            });
        }
        public Task<bool> EditarProductoAsync(int id,Producto p)
        {
            return Task.Run(() =>
            {
                using (DSPEntities db= new DSPEntities())
                {
                    try
                    {
                        Producto ToEdit = db.Producto.Find(id);
                        ToEdit.nombre = p.nombre;
                        ToEdit.id_categoria = p.id_categoria;
                        ToEdit.imagen_producto = p.imagen_producto;
                        ToEdit.cantidad = p.cantidad;
                        ToEdit.precio_venta = p.precio_venta;
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e) {
                        return false;
                    }
                }
                    
            });
        }
        public Task<bool> AgregarCategoriaAsync(Categoria c)
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities()) {
                    try {
                        db.Categoria.Add(c);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e) {
                        return false;
                    }

                }
            });
        }
        public Task<List<Cargo>> ObtenerCargosAsync()
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities())
                {
                    try
                    {
                        return (from data in db.Cargo
                                select data).ToList();
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }
            });

        }


        public Task<bool> AgregarCargoAsync(Cargo c)
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities())
                {
                    try
                    {
                        db.Cargo.Add(c);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                }
            });
        }
        public Task<bool> EliminarCategoriaAsync(int id)
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities())
                {
                    try { 
                        Categoria categoria = db.Categoria.Find(id);
                        db.Categoria.Remove(categoria);
                        db.SaveChanges();
                        return true;
                    }catch(Exception e)
                    {
                        return false;
                    }
                }
            });
        }
        public Task<Categoria> ObtenerCategoriaAsync(int id)
        {
            return Task.Run(() =>
            {
            using (DSPEntities db = new DSPEntities())
                {
                    try
                    {
                        return db.Categoria.Find(id);
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }
            });
        }
        public Task<bool> ActualizarCategoriaAsync(int id,Categoria c,bool ChangeImage)
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities()) { 
                    try
                    {
                        Categoria ToEdit = db.Categoria.Find(id);
                        ToEdit.nombre_categoria = c.nombre_categoria;
                        ToEdit.descripcion = c.descripcion;
                        if (ChangeImage)
                        {
                            ToEdit.imagen_categoria = c.imagen_categoria;
                        }
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
            });
        }


        public Task<List<Categoria>> ObtenerCategoriasAsync()
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities())
                {
                    try
                    {
                        return (from data in db.Categoria.Include("Producto")
                                select data).ToList();
                    }
                    catch (Exception e)
                    {

                        return null;
                    }
                }
            });
        }
        public Task<bool> AgregarEmpleadoAsync(Empleado empleado)
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities())
                {
                    try
                    {
                        db.Empleado.Add(empleado);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;

                    }
                }
            });
        }



    }//Clase
}//NameSpace

