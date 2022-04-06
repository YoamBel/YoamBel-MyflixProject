import React, { useState,useEffect } from 'react';
import { StyleSheet,Alert, TextInput,Text, Image, View,Dimensions,Linking,ScrollView,TouchableOpacity,Input, FlatList } from 'react-native';
import { AntDesign } from '@expo/vector-icons';
import { MaterialIcons } from '@expo/vector-icons';
import CardSearch from './FormeCard/CardSearch'
//import { useNavigation } from '@react-navigation/native';


movieUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/movie'
serieUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/serie'
animeUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/anime'
favorieUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/favorie'

const SearchBar = (props) =>{


    const [filterData , setfilterData] = useState([])
    const [masterData , setMasterData] = useState([])
    const [search , setSearch] = useState('')

    const [IDM ,setIDM] = useState([])
    const [TitleM ,setTitleM] = useState([])
    const [PictureM ,setPictureM] = useState([])
    const [LinkM ,setLinkM] = useState([])

    const [title , setTitle] = useState('')
    const [ valid , setvalid] = useState(true)
    const [obj ,setobj]  = useState([])


    // Movie
    useEffect(()=> {
        fetchPost();
        return () => {}
    },[])

    const fetchPost = () =>{
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

            setfilterData(result) 
            setMasterData(result)                   
          },
          (error) => {
          alert(error);
          })
          //.finally(() => setLoading(false))
        
    }
    
    const searchFilter = (text) => {
        if(text){
            const newData = masterData.filter((item) => {
                const itemData = item.Title ? 
                                item.Title.toUpperCase() : ''.toUpperCase()
                
                const textData = text.toUpperCase()
                return itemData.indexOf(textData) > -1;
            })
            setfilterData(newData)
            setSearch(text)
            
        }
        else{
            setfilterData(masterData)
            setSearch(text)
        }
    }
    

    
  
    


    const ItemView = ({item}) => {
        return (
            <TouchableOpacity style = {{flexDirection:'row' ,margin :10}} onPress = {() => Linking.openURL(item.Link)}>
                <Image style={{width: 50, height: 82.5,   borderTopLeftRadius: 15}} source={{uri: `data:image/image;base64,${item.Picture}`}}/>
                <Text style = {{color : 'white' ,fontFamily:'sans-serif-light' ,fontSize: 20 ,fontWeight:'bold'}}>{item.Title}</Text>   
            </TouchableOpacity>
            
        )
    }
    const ItemSeparatorView = () => {
        return (
            <View style = {{height : 0.5 ,width: '100%' ,backgroundColor:'white'}}/>
        )
    }
   


    return (
        <ScrollView style={styles.container}>
                <View style={styles.searchContainer}>

                    <View style={styles.vwSearch}>
                        <AntDesign name="search1" size={22} color="black"  style={styles.icSearch} />   
                    </View>
                    
                  
                    <TextInput
                        value = {search}
                        style={styles.textInput}
                        placeholder = "Search"
                        underlineColorAndroid = "transparent"
                        onChangeText = {((text) => searchFilter(text))}/>
                     
                    
                </View>

                <FlatList
                data = {filterData}
                keyExtractor = {(item ,index) => index.toString()}
                ItemSeparatorComponent = {ItemSeparatorView}
                renderItem = {ItemView}/>
           
               
        </ScrollView>
       
    );
  }
  
  const styles = StyleSheet.create({
    container: {
        backgroundColor : 'black'
    },
    searchContainer:
    {
        backgroundColor: 'white',
        width: '100%',
        height: 40,
        flexDirection: 'row'

    },
    icSearch: {
       margin : 5,
    },
    vwSearch: {
        flex:0.15,
        justifyContent: 'center',
        alignItems: 'center',
        // width: 40,
        // backgroundColor: 'red'
    },
    vwClear: {
        flex: 0.2,
        justifyContent: 'center',
        alignItems: 'center',
    },
    textInput: {
        //backgroundColor: 'green',
        flex: 1,
    },
    vwClear: {
        //backgroundColor: 'yellow',
        flex: 0.2,
        justifyContent: 'center',
        alignItems: 'center',
    },
    txtError: {
        marginTop: '2%',
        width: '89%',
        color: 'white',

    },
  });
  
  export default  SearchBar;


  {/*import React, { Component } from 'react';
import { StyleSheet, Text, View, ScrollView, TouchableOpacity } from 'react-native';
import SearchInput, { createFilter } from 'react-native-search-filter';
import emails from './emails';
const KEYS_TO_FILTERS = ['user.name', 'subject'];

export default class App extends Component<{}> {
 constructor(props) {
    super(props);
    this.state = {
      searchTerm: ''
    }
  }
  searchUpdated(term) {
    this.setState({ searchTerm: term })
  }
  render() {
    const filteredEmails = emails.filter(createFilter(this.state.searchTerm, KEYS_TO_FILTERS))
    return (
      <View style={styles.container}>
        <SearchInput 
          onChangeText={(term) => { this.searchUpdated(term) }} 
          style={styles.searchInput}
          placeholder="Type a message to search"
          />
        <ScrollView>
          {filteredEmails.map(email => {
            return (
              <TouchableOpacity onPress={()=>alert(email.user.name)} key={email.id} style={styles.emailItem}>
                <View>
                  <Text>{email.user.name}</Text>
                  <Text style={styles.emailSubject}>{email.subject}</Text>
                </View>
              </TouchableOpacity>
            )
          })}
        </ScrollView>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    justifyContent: 'flex-start'
  },
  emailItem:{
    borderBottomWidth: 0.5,
    borderColor: 'rgba(0,0,0,0.3)',
    padding: 10
  },
  emailSubject: {
    color: 'rgba(0,0,0,0.5)'
  },
  searchInput:{
    padding: 10,
    borderColor: '#CCC',
    borderWidth: 1
  }
}); */}