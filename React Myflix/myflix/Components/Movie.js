import React, { useState,useEffect } from 'react';
import { StyleSheet, Image, Text, View,Dimensions,TextInput,ActivityIndicator,ScrollView,TouchableOpacity,Input } from 'react-native';
import ImagesSwiper from "react-native-image-swiper";
import CardInformationOfMovie from './FormeCard/CardInformationOfMovie'
import { AntDesign } from '@expo/vector-icons';
import { MaterialIcons } from '@expo/vector-icons';
import SearchInput, { createFilter } from 'react-native-search-filter';
import { Title } from 'react-native-paper';
import SearchBar from './SearchBar'
//import CardSearch from './FormeCard/CardSearch';
import CardSearch from '../Components/FormeCard/CardSearch'

import { useNavigation } from '@react-navigation/native';




const customImg = [
  'https://www.avforums.com/styles/avf/editorial/block//e96b98ba397e57eb5f8d72c07e620b7f_3x3.jpg',
  'https://wallpaperaccess.com/full/38000.jpg',
  'https://images6.alphacoders.com/902/thumb-1920-902379.jpg',
  'https://www.xtrafondos.com/wallpapers/the-batman-oscuridad-dc-7096.jpg'
];

const {width} = Dimensions.get('window')
const {height} = Dimensions.get('window')

//const KEYS_TO_FILTERS = ['title', 'subject'];

movieUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/movie'

const Movie = () =>{

  const [isLoading , setLoading] = useState(true);
  const [dataMovie , setDataMovie] = useState([])
  const dataMovie1 = []
  const dataMovie2 = []
  const dataMovie3 = []
  const dataMovie4 = []
  const dataMovie5 = []
  const dataMovie6 = []
  const [valid, setValid] = useState(false)
  const [dataSearch, setDataSearch] = useState([])
  const [dataTitle, setDataTitle] = useState([])
  const arrTitle = []


  //const [seachTerm, setSearchTrem] = useState('')

  const navigation = useNavigation()

  const [query, setQuery] = useState();
  const [error, setError] = useState()

  {
    for (var i = 0 ; i < dataMovie.length;i++)
    {
      if(i < 6){dataMovie1.push(dataMovie[i])}
      else if(i < 12 ){dataMovie2.push(dataMovie[i])}
      else if(i < 18){dataMovie3.push(dataMovie[i])}
      else if(i < 24){dataMovie4.push(dataMovie[i])}
      else if(i < 30){dataMovie5.push(dataMovie[i])}
      else{dataMovie6.push(dataMovie[i])}
    }
   
  }
  

   useEffect(() => {
        fetch(movieUrl , {
            method:'GET',
            headers : new Headers({
                'Content-Type':'application/json;charset=UTF-8'
            })
        })
        .then( res => {
            return res.json()
        })
        .then((result) => {
            let arr = []           
            result.map(st=> arr.push(
              
              <TouchableOpacity onPress = {informationOfMovie}>
                <Text style = {{height:1}}>{st.ID}</Text>
                <View style = {styles.image}>
                  <Image style={{width: 145, height: 210 ,borderColor: 'write'}} source={{uri: `data:image/image;base64,${st.Picture}`}}/>
                </View>
              </TouchableOpacity>
            ))
            setDataMovie(arr) 
            let arrSearch = [] 
            result.map( st => arrSearch.push( st.Title, st.Picture))
            setDataSearch(arrSearch)
    
            let arrTitle = [] 
            result.map( st => arrTitle.push( st.Title))
            setDataTitle(arrTitle)
                    
          },
          (error) => {
          alert(error);
          })
          .finally(() => setLoading(false))
        
    },[])

    const informationOfMovie = () =>{

      fetch(movieUrl , {
        method:'GET',
        headers : new Headers({
            'Content-Type':'application/json;charset=UTF-8'
        })
    })
    .then( res => {
        return res.json()
    })
    .then((result) => {
        let arr = []           
        result.map(st=> arr.push(
          <CardInformationOfMovie
            style = {styles.cardInformation}
            ID = {st.ID}
            Title = {st.Title}
            Categorie = {st.Categorie} 
            Picture = {st.Picture}
            Average = {st.Average} 
            Genre = {st.Genre} 
            TextDescription = {st.TextDescription}
            Link = {st.Link}/>
           
        ))
        setDataMovie(arr) 

       
          
      },
      (error) => {
      alert(error);
      })
      .finally(() => setLoading(false))

    }

  
    

    //const filteredTitle = dataTitle.filter(createFilter(searchTerm, KEYS_TO_FILTERS))

    return (
      <View style={styles.container}>
        {isLoading ? (<ActivityIndicator size="large" color="red"/>
                ) : (
        <ScrollView>
         <ImagesSwiper 
              images={customImg}
              autoplay={true} 
              autoplayTimeout={2.5}
              showsPagination={false}
              width={width} 
              height={height - 550} 
            />
             <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Tendance</Text>
             <ScrollView horizontal={true}>              
                 <View style={styles.movie}>
                      {dataMovie1}
                  </View>                
            </ScrollView>
            <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Comedy</Text>
            <ScrollView horizontal={true}>
                <View style={styles.movie}>
                    {dataMovie2}
                </View>
            </ScrollView>
            <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Action</Text>
            <ScrollView horizontal={true}>
                <View style={styles.movie}>
                    {dataMovie3}
                </View>
            </ScrollView>
            <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Top Momment</Text>
            <ScrollView horizontal={true}>
                <View style={styles.movie}>
                    {dataMovie4}
                </View>
            </ScrollView>
            <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Actuality</Text>
            <ScrollView horizontal={true}>
                <View style={styles.movie}>
                    {dataMovie5}
                </View>
            </ScrollView>
            <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>New Movie Add</Text>
            <ScrollView horizontal={true}>
                <View style={styles.movie}>
                    {dataMovie6}
                </View>
            </ScrollView>
        </ScrollView>)}
         
      </View>

    );
}
  
const styles = StyleSheet.create({
  container: {
    flex: 1,
    marginTop: 0,
    backgroundColor:'black'
  },
  movie:{
    display:'flex',
    flexDirection:"row",
    marginTop:10,
  },
  image:{
    paddingRight:10,
    paddingLeft:10
  },
  cardInformation:{
    backfaceVisibility :'hidden'
  },
  vwSearch:{
    backgroundColor:'white',
  },
});
  
  export default  Movie;


  