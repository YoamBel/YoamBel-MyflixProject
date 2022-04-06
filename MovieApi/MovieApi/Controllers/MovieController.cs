using MovieApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;


namespace MovieApi.Controllers
{
    public class MovieController : ApiController
    {

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/movie")]
        public IHttpActionResult GetM()
        {
            try
            {
                MovieDBService movieDBService = new MovieDBService();
                return Ok(movieDBService.GetMoviesView());
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/serie")]
        public IHttpActionResult GetS()
        {
            try
            {
                MovieDBService movieDBService = new MovieDBService();
                return Ok(movieDBService.GetSeriesView());
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/anime")]
        public IHttpActionResult GetA()
        {
            try
            {
                MovieDBService movieDBService = new MovieDBService();
                return Ok(movieDBService.GetAnimesView());
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/favorie")]
        public IHttpActionResult GetF()
        {
            try
            {
                MovieDBService movieDBService = new MovieDBService();
                return Ok(movieDBService.GetFavorieView());
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }





        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/movie")]
        public IHttpActionResult PostM([FromBody] Movie movie)
        {

            try
            {
                MovieDBService movieDBService = new MovieDBService();
                return Ok(movieDBService.PostMovieSave(movie));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }


        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/serie")]
        public IHttpActionResult PostS([FromBody] Serie serie)
        {

            try
            {
                MovieDBService movieDBService = new MovieDBService();
                return Ok(movieDBService.PostSerieSave(serie));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }


        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/anime")]
        public IHttpActionResult PostA([FromBody] Anime anime)
        {

            try
            {
                MovieDBService movieDBService = new MovieDBService();
                return Ok(movieDBService.PostAnimeSave(anime));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/favorie")]
        public IHttpActionResult PostF([FromBody] Favorie favorie)
        {

            try
            {
                MovieDBService movieDBService = new MovieDBService();
                return Ok(movieDBService.PostFavorieSave(favorie));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }





        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("api/movie/{ID}")]
        public IHttpActionResult PutM(int id, [FromBody] Movie movie)
        {

            try
            {
                MovieDBService movieDBService = new MovieDBService();
                return Ok(movieDBService.PutMovieUpdate(movie, id));
            }      
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }


        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("api/serie/{ID}")]
        public IHttpActionResult PutS(int id, [FromBody] Serie serie)
        {

            try
            {
                MovieDBService movieDBService = new MovieDBService();
                return Ok(movieDBService.PutSerieUpdate(serie, id));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
            


        }


        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("api/anime/{ID}")]
        public IHttpActionResult PutA(int id, [FromBody] Anime anime)
        {

            try
            {
                MovieDBService movieDBService = new MovieDBService();
                return Ok(movieDBService.PutAnimeUpdate(anime, id));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }




        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("api/movie/{ID}")]
        public IHttpActionResult DeleteM(int id)
        {
            try
            {
                MovieDBService movieDBService = new MovieDBService();
                movieDBService.DeleteMovieRemove(id);
                return Ok("The Movie is Deleted");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }


        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("api/serie/{ID}")]
        public IHttpActionResult DeleteS(int id)
        {
            try
            {
                MovieDBService movieDBService = new MovieDBService();
                movieDBService.DeleteSerieRemove(id);
                return Ok("The serie is Deleted");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }


        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("api/anime/{ID}")]
        public IHttpActionResult DeleteA(int id)
        {
            try
            {
                MovieDBService movieDBService = new MovieDBService();
                movieDBService.DeleteAnimeRemove(id);
                return Ok("The serie is Deleted");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }


        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("api/favorie/{ID}")]
        public IHttpActionResult DeleteF(int id)
        {
            try
            {
                MovieDBService movieDBService = new MovieDBService();
                movieDBService.DeleteFavorieRemove(id);
                return Ok("The serie is Deleted");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}